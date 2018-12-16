import { Component, OnInit } from '@angular/core';
import { ConfigurationService } from '../service/configuration.service';

@Component({
  selector: 'app-main-header',
  templateUrl: './main-header.component.html',
  styleUrls: ['./main-header.component.scss']
})
export class MainHeaderComponent implements OnInit {

  logoUrl = './assets/img/logo.png';
  logoAlt: string;
  isShowSearchbox: boolean;
  searchTextPlaceholder: string;
  searchButtonText: string;
  isShowWishlist: boolean;
  wishlistText: string;
  isShowCart: boolean;
  cartText: string;

   constructor(
    private configService: ConfigurationService) {
  }

  ngOnInit() {
    this.onLoadConfigurations();
  }

  onLoadConfigurations() {
    this.configService.getIsReady().subscribe((val) => {
      if (val) {
        this.logoUrl = this.configService.getKeyValue('app-logo-url');
        this.logoAlt = this.configService.getKeyValue('app-logo-alt');
        this.isShowSearchbox = this.configService.getKeyValue('app-searchbox-is-show') === "1" ? true: false;
        this.searchTextPlaceholder = this.configService.getKeyValue('app-searchbox-placeholder-text');
        this.searchButtonText = this.configService.getKeyValue('app-searchbtn-text');
        this.isShowWishlist = this.configService.getKeyValue('app-wishlist-is-show') === "1" ? true: false;
        this.wishlistText = this.configService.getKeyValue('app-wishlist-text');
        this.isShowCart = this.configService.getKeyValue('app-cart-is-show') === "1" ? true: false;
        this.cartText = this.configService.getKeyValue('app-cart-text');

      }
    });
  }
}
