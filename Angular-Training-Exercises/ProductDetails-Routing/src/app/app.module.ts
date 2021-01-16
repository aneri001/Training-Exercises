import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductInfoDisplayComponent } from './product-info-display/product-info-display.component';
import { ProductInfoService } from './product-info.service';
import { ProductInfoVariable } from './Product-Info-Variable';
import { SearchFunctionalityComponent } from './search-functionality/search-functionality.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductInfoDisplayComponent,
    SearchFunctionalityComponent,
    HomeComponent
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [ ProductInfoService,ProductInfoVariable],
  bootstrap: [AppComponent]
})
export class AppModule { }
