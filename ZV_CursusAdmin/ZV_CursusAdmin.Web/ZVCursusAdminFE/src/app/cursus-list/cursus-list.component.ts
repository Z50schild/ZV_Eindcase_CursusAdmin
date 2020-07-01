import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-cursus-list',
  templateUrl: './cursus-list.component.html',
  styleUrls: ['./cursus-list.component.css']
})

export class CursusListComponent implements OnInit {

  constructor(private httpService: HttpClient) { }
  cursussen: string[];


  ngOnInit(): void {
    this.httpService.get('http://localhost:44318/Api/CursusInstantie').subscribe(
      data => {
        this.cursussen = data as string []
      }
    )
  }

}
