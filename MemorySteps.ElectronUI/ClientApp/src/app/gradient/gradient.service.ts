import { Injectable } from '@angular/core'

@Injectable()
export class GradientService {
  gradients = [
    {
        "name": "App Theme",
        "colors": ["#2c4676", "#3760aa"]
    },
    {
        "name": "Deep Purple",
        "colors": ["#673AB7", "#512DA8"]
    },
    {
        "name": "Skyline",
        "colors": ["#1488CC", "#2B32B2"]
    },
    {
        "name": "Aqua Marine",
        "colors": ["#1A2980", "#26D0CE"]
    }
  ]
}