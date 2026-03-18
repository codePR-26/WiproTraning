
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {HeaderComponent} from './components/header/header.component';
import {FooterComponent} from './components/footer/footer.component';
import {HomeComponent} from './pages/home/home.component';
import {LoginComponent} from './pages/login/login.component';
import {RegisterComponent} from './pages/register/register.component';
import {AppRoutingModule} from './app-routing.module';

@NgModule({
 declarations:[
  HeaderComponent ,
  FooterComponent,
  HomeComponent,
  LoginComponent,
  RegisterComponent
 ],
 imports:[BrowserModule , AppRoutingModule , RouterModule],
 providers:[],
 bootstrap:[HeaderComponent]
})
export class AppModule { }
