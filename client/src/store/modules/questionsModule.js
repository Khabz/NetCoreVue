import axios from "axios";
import { REST_URI } from "../../config/key"

const state = {
    status: "",
    errors: [],
    questions: []
};

const mutations = {
    questions_request() {
        state.errors = null;
        state.status = "loading";
    },
    questions_success(questions) {
        state.errors = null;
        state.status = "success";
        state.questions = questions
    }
};

const actions = {
    // Get question action
    async getQuestions({ commit }) {
        axios.get(`${REST_URI}/api/question`).then((res) => {
            let results = res.data;
            state.questions.push(results)
        }).catch(error => {
            console.log(error.response)
            commit("")
        })
    }
}
const getters = {
    errors: state => state.errors,
    status: state => state.status,
    questions: state => state.questions
};

export default {
    state,
    actions,
    mutations,
    getters
};