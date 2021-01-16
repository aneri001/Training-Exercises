import { Component, OnInit } from '@angular/core';
import { ProductInfoService } from '../product-info.service';

@Component({
  selector: 'app-product-info-display',
  templateUrl: './product-info-display.component.html',
  styleUrls: ['./product-info-display.component.css']
})

export class ProductInfoDisplayComponent implements OnInit {
  productData:any;
  msg: string='';

  constructor(private productdata: ProductInfoService) { }

  ngOnInit(): void {
    this.productData= this.productdata.ProductData;  
  }

  showData(pr:ProductInfoService){
      this.msg= 'Product Name: ' + pr.productName +
                      '\nProduct Code: ' + pr.productCode +
                      '\nBranch Name: ' + pr.branchName +
                      '\nBranch Code: ' + pr.branchCode +
                      '\nShipping Address: ' + pr.shippingAddress;
      alert(this.msg);
  }
}
