﻿using Blazored.LocalStorage;
using Dreamer.Data;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dreamer.Services.CartService
{
    public class SalesReturnCartService : ISalesReturnService
    {
        private readonly ILocalStorageService _localStorage;

        public event Action OnChange;

        public SalesReturnCartService(
            ILocalStorageService localStorage
            )
        {
            _localStorage = localStorage;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("srcart");
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
                else if (item.CartStatus == "equal")
                {
                    //sameItem.Qty = item.Qty;
                }
                else if (item.CartStatus == "edit")
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
                    sameItem.NetAmount = Math.Round(decNetValue + decTaxAmount, 2);
                    sameItem.TotalAmount = Math.Round(decGrndTotl + decTaxAmount, 2);
                }
                else
                {
                    sameItem.Discount = 0;
                }
            }

            await _localStorage.SetItemAsync("srcart", cart);

        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("srcart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("srcart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("srcart", cart);
            //OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("srcart");
            //OnChange.Invoke();
        }
    }
}
