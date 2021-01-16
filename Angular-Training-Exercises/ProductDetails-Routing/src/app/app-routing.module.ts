import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductInfoDisplayComponent } from './product-info-display/product-info-display.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
const routes: Routes = [ 
  { path: 'productInfo', component: ProductInfoDisplayComponent},
  { path: 'welcome', component: AppComponent },
  {path: 'home',component :HomeComponent},
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
