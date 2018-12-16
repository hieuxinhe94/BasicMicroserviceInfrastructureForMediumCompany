import { Component, OnInit } from '@angular/core';
import { ConfigurationService } from '../service/configuration.service';
import { Observable, BehaviorSubject } from 'rxjs'; 

@Component({
  selector: 'app-top-banner',
  templateUrl: './top-banner.component.html',
  styleUrls: ['./top-banner.component.scss']
})
export class TopBannerComponent implements OnInit {

  isShowHotDeal = true;
  isShowSlide: boolean;

  // config of display type of showHotDeal
  hotdealTimeCountDown$ = new BehaviorSubject<Date>(new Date());
  hotdealText: string;
  hotdealDesc: string;
  hotdealButtonText: string;

  // config of display type of show slides
  slides: [];

  constructor(
    private configService: ConfigurationService) {

  }

  ngOnInit() {
    this.onLoadConfigurations();
  }
    


  onLoadConfigurations() {
    this.configService.getIsReady().subscribe((val) => {
      if (val) {
        this.isShowHotDeal = this.configService.getKeyValue('app-section-hotdeal-is-show') === "1" ? true : false;
        if (this.isShowHotDeal) {
          this.isShowSlide = false;
          this.hotdealText = this.configService.getKeyValue('app-section-hotdeal-text');
          this.hotdealDesc = this.configService.getKeyValue('app-section-hotdeal-description');
          this.hotdealButtonText = this.configService.getKeyValue('app-section-hotdeal-button-text');
          let dateEnd =  this.configService.getKeyValue('app-section-hotdeal-date-end');
        }
      }
    })
  };
}
