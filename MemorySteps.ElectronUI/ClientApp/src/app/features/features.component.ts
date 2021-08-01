import { Component, OnDestroy } from '@angular/core';
import { NavItem } from './ui/model/nav-item';
import { MediaChange, MediaObserver } from "@angular/flex-layout";
import { Subscription } from 'rxjs';
import { menu } from './ui/model/menu';
import { GradientService } from '../gradient/gradient.service';

@Component({
  selector: 'app-features',
  templateUrl: './features.component.html',
  styleUrls: ['./features.component.css']
})
export class FeaturesComponent implements OnDestroy {
    Title: string = 'Placeholder title';

    public opened: boolean = true;
    public mediaWatcher: Subscription;
    public menu: NavItem[] = menu;

    constructor(private media: MediaObserver) {
        this.mediaWatcher = this.media.media$.subscribe((mediaChange: MediaChange) => {
            this.handleMediaChange(mediaChange);
        })
    }

    private handleMediaChange(mediaChange: MediaChange) {
        if (this.media.isActive('lt-md')) {
            this.opened = false;
        } else {
            this.opened = true;
        }
    }

    changeName(newTitle: string):void{
        this.Title = newTitle;
    }

    ngOnDestroy() {
        this.mediaWatcher.unsubscribe();
    }

    ngOnInit() {
    }
  
}