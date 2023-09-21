/// @description Insert description here
// You can write your code in this editor
if(other.sprite_index == spr_mirror2)
{
	if(image_angle == 0)
	{
		x = other.x;
		y = other.y + 64;
		image_angle -= 90;
		if(image_angle == -90)
		{
			image_angle = 270;
		}
		direction = image_angle;
	}
	else if(image_angle == 90)
	{
		x = other.x - 64;
		y = other.y;
		image_angle = (image_angle + 90) mod 360;
		direction = image_angle;
	}
	else if(image_angle == 180)
	{
		x = other.x;
		y = other.y - 64;
		image_angle -= 90;
		if(image_angle == -90)
		{
			image_angle = 270;
		}
		direction = image_angle;
	}
	else if(image_angle == 270)
	{
		x = other.x + 64;
		y = other.y;
		image_angle = (image_angle + 90) mod 360;
		direction = image_angle;
	}
}
else if(other.sprite_index == spr_mirror1)
{
	if(image_angle == 0)
	{
		x = other.x;
		y = other.y - 64;
		image_angle = (image_angle + 90) mod 360;
		direction = image_angle;
	}
	else if(image_angle == 90)
	{
		x = other.x + 64;
		y = other.y;
		image_angle -= 90;
		if(image_angle == -90)
		{
			image_angle = 270;
		}
		direction = image_angle;
	}
	else if(image_angle == 180)
	{
		x = other.x;
		y = other.y + 64;
		image_angle = (image_angle + 90) mod 360;
		direction = image_angle;
	}
	else if(image_angle == 270)
	{
		x = other.x - 64;
		y = other.y;
		image_angle -= 90;
		if(image_angle == -90)
		{
			image_angle = 270;
		}
		direction = image_angle;
	}
}