import { Component, OnInit } from '@angular/core';
import { RegitrationService } from '../shared/regitration.service';
import { Registration } from '../shared/registration.model';

@Component({
  selector: 'app-registrationpage',
  templateUrl: './registrationpage.component.html',
  styles: []
})
export class RegistrationpageComponent implements OnInit {

  constructor(private service:RegitrationService) { }

  ngOnInit() {
    this.service.loadRegisteredList();
  }

  EditData(data:Registration){
    this.service.formData=Object.assign({},data);
  }

}
