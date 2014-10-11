Zoo.AnimalsRoute = Em.Route.extend({
    model: function () {
        // this will always make an ajax call looking for all animals the server knows about (or will return)
        return this.store.find('animal');
    }
});

// If you want to use the exact same route as your parent and 
// (you are a route and your parent is a resource) then you don't need to define it
// it's the default implementation for Ember
//Zoo.AnimalsIndexRoute = Em.Route.extend({
//    model: function () {
//        return this.modelFor('animals');
//    }
//});