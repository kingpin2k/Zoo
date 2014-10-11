Zoo.StarsRoute = Ember.Route.extend({
    model: function () {
        // ember likes POJOs just as much as it likes Ember Data
        return {
            starCount: 200,
            refresh: 50
        };
    }
});