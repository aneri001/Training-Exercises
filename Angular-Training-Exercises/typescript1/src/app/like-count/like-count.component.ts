import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-like-count',
  templateUrl: './like-count.component.html',
  styleUrls: ['./like-count.component.css']
})
export class LikeCountComponent implements OnInit {

  constructor() { }
  public like: number = 0;
  //function to count likes
  getLikes()
  {
    //iterating number of likes 
        this.like++;
        console.log("liked", this.like);
 //function to count dislike      
  }
  getDisLikes()
  {
      //decreasing likes
      this.like--;
      console.log("unliked", this.like);   
  }
  ngOnInit(): void {

    console.log("unlike");
   
  }

}
