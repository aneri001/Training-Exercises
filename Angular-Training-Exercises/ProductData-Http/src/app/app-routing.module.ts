import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddProductComponent } from './add-product/add-product.component';
import { AppComponent } from './app.component';
import { PostComponent } from './post/post.component';
import { UpdateProductComponent } from './update-product/update-product.component';

const routes: Routes = [
  { path : 'newProduct', component : AddProductComponent },
  { path: 'welcome', component: AppComponent },
  { path: 'productlist', component: PostComponent},
  { path: 'productlist/updateProduct', component: UpdateProductComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
