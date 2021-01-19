import { Component, OnInit } from '@angular/core';
import { ProductClass } from '../productsclass';

@Component({
  selector: 'app-update-product',
  templateUrl: './update-product.component.html',
  styleUrls: ['./update-product.component.css']
})
export class UpdateProductComponent implements OnInit {
  oldProductName: string;
  oldProductCode:string;
  oldBranchName:string;
  oldBranchCode: string;
  oldShippingAddress: string;
  updateValue: ProductClass;

  constructor() { }

  ngOnInit(): void {
  }
  fetchItemOriginalData(event){

    this.oldProductName = event.productName;
    this.oldProductCode = event.productCode;
    this.oldBranchName = event.branchName;
    this.oldBranchCode = event.branchCode;
    this.oldShippingAddress = event.shippingAddress;
  }
  updateItem() {
    let post = {
     productName : this.updateValue.productName,
     productCode : this.updateValue.productCode,
     branchName : this.updateValue.branchName,
     branchCode : this.updateValue.branchCode,
     shippingAddress : this.updateValue.shippingAddress
    }
    console.log("Updated product Information: " + "\nProduct Name: " + post.productName +
    "\nProduct Code: " + post.productCode + "\nBranch Name: " + post.branchName +
    "\nBranch Code: " + post.branchCode + "\nShipping Address: " + post.shippingAddress);
  }

}
