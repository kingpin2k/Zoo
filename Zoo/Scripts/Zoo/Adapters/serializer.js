Zoo.ApplicationSerializer = DS.RESTSerializer.extend({
    extractArray: function (store, type, payload) {
        var plu = Ember.String.pluralize(type.typeKey),
            fixed = {};
        fixed[plu] = payload;
        return this._super(store, type, fixed);
    },
    extractSingle: function (store, type, payload, id) {
        var tmp = {};
        tmp[type.typeKey] = payload;
        return this._super(store, type, tmp, id);
    }
});