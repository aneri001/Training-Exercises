import { Component, OnInit } from '@angular/core';
import { PostDataServiceService } from '../post-data-service.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  product: any;
  constructor(private service: PostDataServiceService) { }

  ngOnInit(): void {
    this.service.getPosts()
    .subscribe(response => {
      this.product = response;
      console.log(response);
    });
  }
  createPost(input: HTMLInputElement) {

    let data = { id: input.value };
    input.value = '';

      this.service.createPost(data).subscribe(
        (response : any) => {
          data['id'] = response.id;
         
          this.product.splice(0, 0, data);
          console.log(response);
      })
  }
  

}