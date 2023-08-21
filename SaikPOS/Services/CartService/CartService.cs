using Blazored.LocalStorage;
using SaikPOS.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaikPOS.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorage
            )
        {
            _localStorage = localStorage;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart
                .Find(x => x.ProductId == item.ProductId);
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                if (item.CartStatus == "Dsc")
                {
                    sameItem.Qty += 1;
                }
                else if(item.CartStatus == "equal")
                {
                    //sameItem.Qty = item.Qty;
                }
                else if(item.CartStatus == "edit")
                {
                    //sameItem.Qty = item.Qty;
                }
                else
                {
                    sameItem.Qty -= 1;
                }
                //sameItem.Qty = item.Qty;
                //Calculate
                decimal decGrossValue = 0;
                decimal decPercentgeDiscount = 0;
                decimal decTtlDiscount = 0;
                decimal decNetValue = 0;
                decimal decTaxAmount = 0;
                decimal decTotalTax = 0;
                decimal decGrndTotl = 0;
                if (Convert.ToDecimal(sameItem.Qty) > 0 && Convert.ToDecimal(item.SalesRate) > 0)
                {
                    decGrossValue = Convert.ToDecimal(item.SalesRate) * Convert.ToDecimal(sameItem.Qty);

                    decPercentgeDiscount = Convert.ToDecimal(item.DiscountAmount) * 100 / decGrossValue;
                    decTtlDiscount = decPercentgeDiscount;
                    sameItem.Discount = decPercentgeDiscount;

                    decNetValue = decGrossValue - Convert.ToDecimal(item.DiscountAmount);
                    sameItem.DiscountAmount = item.DiscountAmount;
                    //ClculteT
                    decTaxAmount = decNetValue * item.TaxRate / 100;
                    sameItem.TaxRate = item.TaxRate;
                    sameItem.TaxAmount = Math.Round(decTaxAmount, 2);


                    decGrndTotl = decNetValue;
                    sameItem.Amount = Math.Round(sameItem.Qty * item.SalesRate , 2);
                    sameItem.NetAmount = Math.Round(decNetValue, 2);
                    sameItem.TotalAmount = Math.Round(decGrndTotl, 2);
                }
                else
                {
                    sameItem.Discount = 0;
                }
            }

            await _localStorage.SetItemAsync("cart", cart);

            //var product = await _productService.GetbyId(item.ProductId);
            //_toastService.ShowSuccess("Name", "Added to cart:");

            //OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            //OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            //OnChange.Invoke();
        }
        
    }
}
