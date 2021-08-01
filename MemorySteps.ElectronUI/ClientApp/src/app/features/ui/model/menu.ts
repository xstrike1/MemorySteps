import { NavItem } from './nav-item';

export let menu: NavItem[] = [
  {
    displayName: 'Dashboard',
    iconName: 'dashboard',
    route: 'home'
  },
  {
    displayName: 'Flows',
    iconName: 'list',
    route: 'flow',
    children: [
      {
        displayName: 'PH Flow 1',
        iconName: 'timeline',
        route: 'flow/info'
      },
      {
        displayName: 'PH Flow 2',
        iconName: 'timeline',
        route: 'fflows/getflow/2'
      }
    ]
  },
  {
    displayName: 'Settings',
    iconName: 'settings',
    route: 'settings',
  }
];