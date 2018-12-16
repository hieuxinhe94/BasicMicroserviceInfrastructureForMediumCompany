import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { PageNotFoundComponent } from './shared/page-not-found/page-not-found.component';
import { IndexComponent } from './shared/index/index.component';
import { CategoryDetailComponent } from './category-detail/category-detail.component';
import { CartDetailComponent } from './cart-detail/cart-detail.component';

const routes: Routes = [
  {
    path: '',
    component: IndexComponent
  },
  {
    path: 'item',
    component: ProductDetailComponent
  }, 
   {
    path: 'cat',
    component: CategoryDetailComponent
  },
  {
    path: 'cart',
    component: CartDetailComponent
  },
  {
    path: 'admin',
    component: PageNotFoundComponent
  },
  {
    path: '**',
    component: PageNotFoundComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
