import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostDataServiceService {


  constructor(private http: HttpClient) { }

  private url = "./assets/product_data.json";

  getPosts(): any {

    return this.http.get(this.url);
  }
 
  addProduct(post : any) {
    return this.http.post('./assets/product_data.json', JSON.stringify(post))
  }

}
