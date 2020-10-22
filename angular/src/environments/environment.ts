import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'CustomLayouts',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44328',
    redirectUri: baseUrl,
    clientId: 'CustomLayouts_App',
    responseType: 'code',
    scope: 'offline_access CustomLayouts',
  },
  apis: {
    default: {
      url: 'https://localhost:44328',
      rootNamespace: 'CustomLayouts',
    },
  },
} as Config.Environment;
