import { Component, OnInit } from '@angular/core';
import { Menu } from '../model/menu';
import { ConfigurationService } from '../service/configuration.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {

  menus: Menu[] = [ {id : 1, text : 'Home', href : '#', alt :'', class: 'active'},
                    {id : 2, text : 'text 2', href : 'href2', alt :'', class: ''}, 
                    {id : 3, text : 'text 3', href : 'href3', alt :'', class: ''}, 
                    {id : 4, text : 'text 4', href : 'href4', alt :'', class: ''}, 
                    {id : 5, text : 'text 5', href : 'href5', alt :'', class: ''},  ];

  constructor(
    private configService: ConfigurationService) {
  }

  ngOnInit() {
    this.onLoadConfigurations();
  }

  onLoadConfigurations() {
    this.configService.getIsMenuReady().subscribe((val) => {
      if (val) {
        this.menus = this.configService.getMenus;
      }
    });
  }

}
