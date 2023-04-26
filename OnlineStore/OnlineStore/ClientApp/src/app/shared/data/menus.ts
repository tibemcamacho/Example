export interface Menu {
  path: string;
  name: string;
}

export const menuList: Menu[] = [
  {
    path: '/products',
    name: 'Productos'
  },
  {
    path: '/about',
    name: 'Acerca de'
  },
  {
    path: '/contact',
    name: 'Contacto'
  }//,
  //{
  //  path: '/dashboard',
  //  name: 'Dashboard'
  //},
  //{
  //  path: '/doc',
  //  name: 'Doc'
  //}
];
