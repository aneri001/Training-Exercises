import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {

  constructor() { }
  inputstr: string = 'Angular';
  output: string = '';

  stringChange(str:string): void {
    this.output = "This is the app component. I received a string '" + str + "' from the hello component" 
    + " and I capitalize it here " + str.toUpperCase()
  }
  ngOnInit(): void {
  }

}

