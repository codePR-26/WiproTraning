
import {Component} from '@angular/core'
import {FormBuilder,Validators} from '@angular/forms'

@Component({
selector:'app-register',
templateUrl:'./register.component.html'
})
export class RegisterComponent{

constructor(private fb:FormBuilder){}

form=this.fb.group({
name:['',Validators.required],
email:['',[Validators.required,Validators.email]],
password:['',[Validators.required,Validators.minLength(6)]]
})

submit(){
if(this.form.valid){
console.log(this.form.value)
}
}

}
