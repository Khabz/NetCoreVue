<template>
  <b-modal id="postQuestionModal" ref="postQuestionModal" hide-footer title="Post a New Question">
    <b-form>
      <button class="btn btn-primary float-right ml-2" type="submit" >Submit</button>
      <button class="btn btn-secondary float-right" type="reset">Cancel</button>
    </b-form>
  </b-modal>
</template>

<script>
export default {
  data() {
    return {
      title: "",
      body: ""
    }
  }
}
</script>

<style>

</style>