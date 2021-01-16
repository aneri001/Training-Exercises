import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentInfoService {
 studentMark =[
    {"name": "ram","Maths": 88,"Physics" :98,"Chemistry": 87},
    {"name": "shyam","Maths": 78,"Physics" :70,"Chemistry": 97},
    {"name": "suresh","Maths": 68,"Physics" :69,"Chemistry": 57}
   ]
  constructor() { }
  


}