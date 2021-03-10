import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
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
    scope: 'offline_access CPAS2',
  },
  apis: {
    default: {
      url: 'https://localhost:44330',
      rootNamespace: 'CPAS2',
    },
  },
} as Environment;
