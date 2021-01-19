import { Component, OnInit } from '@angular/core';
import { PostDataServiceService } from '../post-data-service.service';
import { ProductClass } from '../productsclass';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  msg:string;
  product: ProductClass;
  constructor(private service: PostDataServiceService) { }

  ngOnInit(): void {
    this.service.getPosts()
    .subscribe(response => {
      this.product = response;
      console.log(response);
    });
  }
  
  deleteData(productName,productCode,branchName,branchCode,shippingAddress){
    console.log("Deleting Product");
    this.msg= 'Product deleted is :\n'+'Product Name: ' + productName +
                    '\nProduct Code: ' +productCode +
                    '\nBranch Name: ' + branchName +
                    '\nBranch Code: ' +branchCode +
                    '\nShipping Address: ' +shippingAddress;
    console.log(this.msg);
}

}