import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { MenuComponent } from './menu/menu.component';
import { TopHeaderComponent } from './top-header/top-header.component';
import { MainHeaderComponent } from './main-header/main-header.component';
import { TopProductSectionComponent } from './top-product-section/top-product-section.component';
import { FooterComponent } from './footer/footer.component';
import { NewsLetterComponent } from './news-letter/news-letter.component';
import { TopSellingComponent } from './top-selling/top-selling.component';
import { TopLastestComponent } from './top-lastest/top-lastest.component';
import { TopDiscountComponent } from './top-discount/top-discount.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { TopBannerComponent } from './top-banner/top-banner.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './service/AuthInterceptor';
import { CartComponent } from './cart/cart.component';
import { TopCategoryComponent } from './top-category/top-category.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { PageNotFoundComponent } from './shared/page-not-found/page-not-found.component';
import { IndexComponent } from './shared/index/index.component';
import { CategoryDetailComponent } from './category-detail/category-detail.component';
import { CartDetailComponent } from './cart-detail/cart-detail.component';
import { ProductDetailReviewComponent } from './product-detail-review/product-detail-review.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    TopHeaderComponent,
    MainHeaderComponent,
    TopProductSectionComponent,
    FooterComponent,
    NewsLetterComponent,
    TopSellingComponent,
    TopLastestComponent,
    TopDiscountComponent,
    LoginComponent,
    RegisterComponent,
    TopBannerComponent,
    CartComponent,
    TopCategoryComponent,
    ProductDetailComponent,
    PageNotFoundComponent,
    IndexComponent,
    CategoryDetailComponent,
    CartDetailComponent,
    ProductDetailReviewComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [
  {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }
],
  bootstrap: [AppComponent]
})
export class AppModule { }
