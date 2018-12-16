import { Component, OnInit } from '@angular/core';
import { ConfigurationService } from '../service/configuration.service';

@Component({
  selector: 'app-top-header',
  templateUrl: './top-header.component.html',
  styleUrls: ['./top-header.component.scss']
})
export class TopHeaderComponent implements OnInit {
  phone: string;
  email: string;
  adress: string;
  language: string;
  
  constructor(
    private configService: ConfigurationService) {
  }

  ngOnInit() {
    this.onLoadConfigurations();
  }

  onLoadConfigurations() {
    this.configService.getIsReady().subscribe((val) => {
      if (val) {
        this.phone = this.configService.getKeyValue('app-phone');
        this.email = this.configService.getKeyValue('app-email');
        this.adress = this.configService.getKeyValue('app-adress');
        this.language = this.configService.getKeyValue('app-language');
      }
    });
  }
}
