import { Injectable } from '@angular/core';
import { Registration } from './registration.model';
import { Registrationpage } from './registrationpage.model';
import {HttpClient} from "@angular/common/http";
import { from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegitrationService {
 formData:Registration;
 RegisteredDatas:Registrationpage[];
 readonly rootURL="http://localhost:49456/api/EmloyeeRegister/"
  constructor(private http:HttpClient) { }

postEmployee(formData:Registration)
{
return this.http.post(this.rootURL+'Employee',formData);
}

updateEmployee(formData:Registration)
{
return this.http.put(this.rootURL+'/'+formData.id,formData);
}

loadRegisteredList(){
  this.http.get(this.rootURL+'Emloyee')
  .toPromise().then(res=>this.RegisteredDatas=res as Registration[]);
}

}
