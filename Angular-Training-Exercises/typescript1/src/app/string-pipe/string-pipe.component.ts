import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-string-pipe',
  templateUrl: './string-pipe.component.html',
  styleUrls: ['./string-pipe.component.css']
})
export class StringPipeComponent implements OnInit {
  data = 'Hello,I am Aneri Adani';
  constructor() {}

  ngOnInit(): void {
    
  }

}
