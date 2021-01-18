import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PostDataServiceService {

  constructor(private http: HttpClient) { }

  private url = "./assets/product_data.json";

  getPosts() {
    return this.http.get(this.url);
  }
  
  createPost(post : any) {
    return this.http.post(this.url, JSON.stringify(post))
  }

}
