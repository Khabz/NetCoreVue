import Vue from "vue";
import Vuex from "vuex";
import questionsModule from "./modules/questionsModule";

Vue.use(Vuex);

export default new Vuex.Store({
    state: {},
    mutations: {},
    actions: {},
    modules: {
        questionsModule
    }
});