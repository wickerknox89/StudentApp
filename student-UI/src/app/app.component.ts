import { Component, OnInit } from '@angular/core';
import { StudentService } from 'services/student.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'student-UI';
  students : any[];
  
  constructor(private studentservice:StudentService) {}
  ngOnInit(): void {
    this.studentservice.getAllStudents().subscribe(data => {
      console.log(data);
      this.students=data;
    })
  }
}
