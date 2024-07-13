import { inject } from '@angular/core';
import { CanMatchFn } from '@angular/router';

import { AuthService } from '../../auth/auth.service';

export const adminGuardGuard: CanMatchFn = (route, state) => {
  const navigationService = inject(AuthService);
  const token = localStorage.getItem('token');
  return token ? true : navigationService.router.navigateByUrl('/admin/dashboard');
};
