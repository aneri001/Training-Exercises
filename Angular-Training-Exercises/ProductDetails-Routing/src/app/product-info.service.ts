import { Injectable } from '@angular/core';
import { ProductInfoVariable } from './Product-Info-Variable';

@Injectable({
  providedIn: 'root'
})
export class ProductInfoService extends ProductInfoVariable {
  
  constructor() {
    super();
  }
  //product variable declaration
  ProductData: ProductInfoVariable[]=[
    {
      productImage:'./assets/cactus.jpg',
      productName: 'cactus',
      productCode: 18,
      branchName: 'ahmedabad',
      branchCode: 3,
      shippingAddress: 'xyz',
     
    },
    {
      productImage:'./assets/paperbag.jpg',
      productName: 'paper bag',
      productCode: 34,
      branchName: 'bhuj',
      branchCode: 8,
      shippingAddress: 'xyz',
  
    },
    {
      productImage:'./assets/bamboo.jpg',
      productName: 'bamboo sticks',
      productCode: 31,
      branchName: 'surat',
      branchCode: 40,
      shippingAddress: 'xyz',
     
    }
  ]

}
