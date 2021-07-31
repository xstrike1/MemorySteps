import { Component } from '@angular/core';
import { GradientService } from '../gradient/gradient.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  gradient = {}

  constructor(private service: GradientService) {}

  ngOnInit() {
    this.gradient = this.service.gradients[0]
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
