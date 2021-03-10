import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'CPAS2',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44330',
    redirectUri: baseUrl,
    clientId: 'CPAS2_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone CPAS2',
  },
  apis: {
    default: {
      url: 'https://localhost:44330',
      rootNamespace: 'CPAS2',
    },
  },
} as Environment;
