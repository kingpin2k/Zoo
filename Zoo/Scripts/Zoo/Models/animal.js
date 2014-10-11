Zoo.Animal = DS.Model.extend({
    name: DS.attr(),
    date_of_birth: DS.attr(),
    image: DS.attr(),
    animal_type: DS.attr(),
    daysOld: function () {
        return moment(this.get('date_of_birth')).fromNow();//('L LT');
    }.property('date_of_birth')
});