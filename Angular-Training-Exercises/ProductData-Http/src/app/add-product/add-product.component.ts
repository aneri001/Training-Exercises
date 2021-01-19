import { Component, OnInit } from '@angular/core';
import { PostDataServiceService } from '../post-data-service.service';
import { ProductClass } from '../productsclass';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  public newitem : ProductClass;
  items: any;
  constructor(private itemservice : PostDataServiceService) { }

  ngOnInit(): void {
    this.newitem = new ProductClass();
  }
  createPost() {
    let post = {
     productName : this.newitem.productName,
     productCode : this.newitem.productCode,
     branchName : this.newitem.branchName,
     branchCode : this.newitem.branchCode,
     shippingAddress : this.newitem.shippingAddress
    }
    console.log("adding");
    this.itemservice.addProduct(post).subscribe(

      (response : any) => {
        this.items.splice(0, 0, post);
          
          console.log(response);
      }
    )
  }

}
