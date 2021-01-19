import { Component, OnInit } from '@angular/core';
import { PostDataServiceService } from '../post-data-service.service';
import { ProductClass } from '../productsclass';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  product: ProductClass;
  constructor(private service: PostDataServiceService) { }

  ngOnInit(): void {
    this.service.getPosts()
    .subscribe(response => {
      this.product = response;
      console.log(response);
    });
  }
  
  

}