
import {Component} from '@angular/core'
import {AuthService} from '../services/auth.service'

@Component({
selector:'app-login',
templateUrl:'./login.component.html'
})
export class LoginComponent{

email=''
password=''

constructor(private auth:AuthService){}

login(){

this.auth.login({
 email:this.email,
 password:this.password
}).subscribe((res:any)=>{

 localStorage.setItem('token',res.token)

})

}

}
