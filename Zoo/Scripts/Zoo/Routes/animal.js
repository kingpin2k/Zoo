Zoo.AnimalRoute = Em.Route.extend({
    model: function (params) {
        // this won't make an ajax call back because we already probably have this
        // animal in the store
        return this.store.find('animal', params.id);
    }
});