import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';


import { StudentmarksComponent } from './studentmarks/studentmarks.component';
import { LikeCountComponent } from './like-count/like-count.component';
import { stringWrap } from './string-pipe.pipe';
import { StringPipeComponent } from './string-pipe/string-pipe.component';



@NgModule({
  declarations: [
    AppComponent,
    stringWrap,
    StringPipeComponent,
    

    StudentmarksComponent,
    LikeCountComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [stringWrap],
  bootstrap: [AppComponent]
})
export class AppModule { }
