
import {Injectable} from '@angular/core'

@Injectable({
 providedIn:'root'
})
export class AuthService{

 login(email:string , password:string){
  return email && password
 }

 register(name:string,email:string,password:string){
  return true
 }

}
