import { Directive, ElementRef, Input } from '@angular/core'


@Directive({
  selector: '[gradient]',
})
export class GradientDirective {

  @Input() gradient = []
  @Input() rotation: number = 180

  constructor(private el: ElementRef) { }

  getGradient() {
    return `${this.rotation}deg, ${this.gradient.join()}`
  }

  setBackground(bg: string) {
    this.el.nativeElement.style.background = bg
  }

  ngOnChanges() {
    this.setBackground(`linear-gradient(${this.getGradient()})`)
  }
}
