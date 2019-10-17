
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
//import { Registration } from 'src/app/shared/registration.model';
import { RegitrationService } from 'src/app/shared/regitration.service';
import { ToastrService } from 'ngx-toastr';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']

})
export class RegistrationComponent implements OnInit {
  myDate = new Date();
  constructor( private service:RegitrationService,
    private regitrationService:RegitrationService,
    private toastr:ToastrService
    
    ) {}

  ngOnInit() {
    this.resetForm();
  }
resetForm(form?:NgForm){
  if(form!=null)
  form.resetForm();
  this.service.formData={
    id:null,
    domainname:'',
      Teamname:'', 
      Firstname:'',  
      Lastname:'', 
      Email:'',  
      Lanid: ''
  };
  this.service.RegisteredDatas=[];
}



onSubmit(form:NgForm){
  if(form.value.id==null)
this.inserRecord(form);
else{
  this.updateRecord(form);
}
}

inserRecord(form:NgForm){
this.service.postEmployee(form.value).subscribe(res=>{
  this.toastr.success('Data Saved Successfully','Employee Register');
  this.resetForm(form);
  this.service.loadRegisteredList();
});
}
updateRecord(form:NgForm){
  this.service.updateEmployee(form.value).subscribe(res=>{
    this.toastr.success('Updated Successfully','Employee Register');
    this.resetForm(form);
  this.service.loadRegisteredList();
  });
}

}
