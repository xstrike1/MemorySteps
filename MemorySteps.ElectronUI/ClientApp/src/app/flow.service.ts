import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class UserAction {
    public actionNumber: number;
    public milisecondsToNextAction: number;
    public position: Point = new Point();
    public dragPosition: Point = new Point();

  constructor(ct: number, ms: number) {
      this.actionNumber = ct;
      this.milisecondsToNextAction = ms;
   }
}

export class Point{
    public x: number = 0;
    public y: number = 0;
    
  constructor() { }
}