import { HelloLibraryTemplatePage } from './app.po';

describe('HelloLibrary App', function() {
  let page: HelloLibraryTemplatePage;

  beforeEach(() => {
    page = new HelloLibraryTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
