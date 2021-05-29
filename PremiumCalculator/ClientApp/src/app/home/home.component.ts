import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public currentCount = 0;
  public premium;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {}
  //constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  //  http.get<Premium>(baseUrl + 'premium').subscribe(result => {
  //    this.premium = result;
  //  }, error => console.error(error));
  //}
  public incrementCounter() {
    this.currentCount++;
  }
 // http://localhost:49483/
  public onSubmit(data) {
    this.http.post("http://localhost:49483/" + 'api/premium' + "?suminsured=" + data.suminsured + "&occupation=" + data.occupation, data).subscribe(result => { this.premium = result; })
    console.warn(data.occupation);
  }
}

//interface Premium {
//  premium: number;
//}
