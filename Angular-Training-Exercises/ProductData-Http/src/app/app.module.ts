import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostComponent } from './post/post.component';
import { PostDataServiceService } from './post-data-service.service';



@NgModule({
  declarations: [
    AppComponent,
    PostComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule
  ],
  providers: [PostDataServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
