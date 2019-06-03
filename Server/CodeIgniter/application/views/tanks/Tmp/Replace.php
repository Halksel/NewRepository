<h2><?php echo $title; ?></h2>

<?php echo validation_errors(); ?>

<?php echo form_open('Tmp/Replace'); ?>

    <label for="id">ID</label>
    <input type="input" name="id" /><br/>

    <label for="name">Name</label>
    <textarea name="name"></textarea><br/>

    <label for="level">Level</label>
    <textarea name="level"></textarea><br/>

    <input type="submit" name="submit" value="replace data" />

</form>


<li> <?php echo $replaced[0]->id ?></li>
<li> <?php echo $replaced[0]->name ?></li>
<li> <?php echo $replaced[0]->level ?></li>
