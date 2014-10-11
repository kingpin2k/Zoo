Zoo.Router.map(function () {
    this.resource('animals', function () { // this defaults to {path: '/animals'}
        this.resource('animal', { path: ':id' }); // this tells ember we have a dynamic resource for the route based on an id in the url
    });
    this.resource('planetarium', function () {
        this.resource('stars', function () {
            this.route('edit');
        });
    });
});