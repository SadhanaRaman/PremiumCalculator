import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-home',
  templateUrl: './premiumcalculator.component.html',
})

export class PremiumCalculatorComponent {
  public currentCount = 0;
  public premium;
  Url: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  { this.Url = baseUrl} 

  public incrementCounter() {
    this.currentCount++;
  }

  public onSubmit(data) {
    this.http.post(this.Url + 'api/premium' + "?suminsured=" + data.suminsured + "&occupation=" + data.occupation + "&birthdate=" + data.birthdate, null).subscribe(result => { this.premium = result + " AUD"; },
      () => {
        this.premium = "Unexpected Error Occured";
      })
  }
}
