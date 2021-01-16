import { Component, OnInit } from '@angular/core';
import { StudentInfoService } from './../student-info.service';

@Component({
  selector: 'app-studentmarks',
  templateUrl: './studentmarks.component.html',
  styleUrls: ['./studentmarks.component.css']
})
export class StudentmarksComponent implements OnInit {
  
 studentinfo:any;
  constructor(private studentInfo: StudentInfoService) { }

  ngOnInit(): void {
    this.studentinfo= this.studentInfo.studentMark;  
  }
  
  avgmarks(data: any){
    return (data.Maths + data.Physics + data.Chemistry)/3;
  }

}